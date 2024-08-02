import { ContentAccount, LinkBold, TextAccount } from "../ContentAccount/StyledContentAccount"

export const Link = ({
    text,
    link
 }) => {
    return (
        <ContentAccount>
            <TextAccount>{text}</TextAccount><LinkBold>{link}</LinkBold>
        </ContentAccount>
    )
}