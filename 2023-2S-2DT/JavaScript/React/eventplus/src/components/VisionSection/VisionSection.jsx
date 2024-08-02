import React from 'react';
import './VisionSection.css';
import Title from '../Title/Title';

const VisionSection = () => {
    return (
        <section className='vision'>
            <div className="vision__box">
                <Title 
                    titleText={"Visão"}
                    color='white'
                    additionalClass='vision__title'
                />

                <p className='vision__text'>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Expedita assumenda praesentium odio deserunt, quibusdam error atque inventore ex, a voluptatem cumque corporis officiis. Similique beatae architecto non odio impedit! Unde.

                    Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ratione voluptas unde mollitia cupiditate laboriosam dolore non. Officiis suscipit repudiandae aspernatur aliquam inventore dolore? At, corporis. Laudantium aliquid dicta saepe magni.
                </p>
            </div>
        </section>
    );
};

export default VisionSection;